﻿namespace SimpleDomain.Tests.Validation
{
    using System.ComponentModel.DataAnnotations;

    public class ObjectVerificationTest
    {
        [Required]
        public string Value { get; set; }
    }
}
