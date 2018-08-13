using System;

namespace API.Core.Domain
{
    public class Base
    {
        public Base()
        {
            IsAtivo = true; 
        }

        public DateTime DataRegistro 
        {
            get
            {
                var currentTime = DateTime.Now;
                return currentTime;
            }
        }

        public bool IsAtivo { get; set; }
        public int CriadoPor { get; set; }
    }
}
