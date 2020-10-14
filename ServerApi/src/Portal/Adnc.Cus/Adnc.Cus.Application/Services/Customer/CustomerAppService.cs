﻿using System.Threading.Tasks;
using AutoMapper;
using Adnc.Common;
using Adnc.Cus.Application.Dtos;
using Adnc.Cus.Core.CoreServices;
using Adnc.Cus.Core.Entities;
using Adnc.Common.Helper;
using Adnc.Core.Shared.IRepositories;
using Adnc.Common.Models;
using Adnc.Application.Shared.Dtos;

namespace Adnc.Cus.Application.Services
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICusManagerService _cusManagerService;
        private readonly IEfRepository<Customer> _customerRepo;
        private readonly IMapper _mapper;
        public CustomerAppService(
             IEfRepository<Customer> customerRepo
            , ICusManagerService cusManagerService
            , IMapper mapper)
        {
            _customerRepo = customerRepo;
            _cusManagerService = cusManagerService;
            _mapper = mapper;
        }

        public async Task Register(RegisterInputDto inputDto)
        {
            var exists = await _customerRepo.ExistAsync(t => t.Account == inputDto.Account);
            if (exists)
                throw new BusinessException(new ErrorModel(ErrorCode.Forbidden, "该账号已经存在"));

            var customer = _mapper.Map<Customer>(inputDto);
            customer.ID = new Snowflake(1, 1).NextId();

            var customerFinace = new CusFinance()
            {
                Account = customer.Account
               ,
                Balance = 0
                ,
                ID = customer.ID
            };

            await _cusManagerService.Register(customer, customerFinace);
        }

        public async Task<SimpleDto<string>> Recharge(RechargeInputDto inputDto)
        {
            if (inputDto.Amount == 0)
                throw new BusinessException(new ErrorModel(ErrorCode.BadRequest, "充值金额不能等于0"));

            var customer = await _customerRepo.FindAsync(new object[] { inputDto.ID });
            if (customer == null)
                throw new BusinessException(new ErrorModel(ErrorCode.Forbidden, "不存在该账号"));

            var cusTransactionLog = new CusTransactionLog()
            {
                ID = new Snowflake(1, 1).NextId()
                ,
                Account = customer.Account
                ,
                ExchangeType = "100"
                ,
                Remark = ""
                ,
                Amount = inputDto.Amount
                ,
                ExchageStatus = "10"
            };

            await _cusManagerService.Recharge(customer.ID, inputDto.Amount, cusTransactionLog);

            return new SimpleDto<string>()
            {
                Result = cusTransactionLog.ID.ToString()
            };
        }
    }
}
