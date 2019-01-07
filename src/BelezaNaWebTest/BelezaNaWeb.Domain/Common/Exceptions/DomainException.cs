﻿using System;
namespace BelezaNaWeb.Domain.Common.Exceptions
{
    public abstract class DomainException : Exception
    {
        protected DomainException(string message) : base(message)
        {

        }
    }
}
