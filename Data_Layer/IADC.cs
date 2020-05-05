using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer
{
    public interface IADC
    {
        public byte[] ReadCsvLead1();
        public byte[] ReadCsvLead2();
        public byte[] ReadCsvLead3();

    }
}
