﻿using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;

namespace CurrencyAPI.Repository.Interfaces
{
    public interface ISendEmailRepository
    {
        List<EmailMessageDTO> SendEmail(string productName, int id);
    }
}
