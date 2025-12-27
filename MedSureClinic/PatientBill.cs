using System;
using System.Collections.Generic;
using System.Text;

namespace MedSureClinic
{
    public class PatientBill
    {
        public string BillId { get; set; }
        public string PatientName { get; set; }
        public bool HasInsurance { get; set; }
        
        public decimal ConsultationFee { get; set; }

        public decimal LabCharges { get; set; }

        public decimal MedicineCharges { get; set; }

        public decimal GrossAmount { get; private set; }

        public decimal DiscountAmount { get; private set; }

        public decimal FinalPayable { get; private set; }

        public void Calculate()
        {
            GrossAmount = ConsultationFee + LabCharges + MedicineCharges;

            if (HasInsurance)
                DiscountAmount = GrossAmount * 0.10m;
            else
                DiscountAmount = 0;

            FinalPayable = GrossAmount - DiscountAmount;
        }
    }
}
