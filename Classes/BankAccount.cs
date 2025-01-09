namespace Classes
{
    public class BankAccount
    {
        // Encapsulation : OOP Kurallarındandır. Verileri kapsülleme anlamına gelir. Yani bir properites - field üzerinde get ve set işlemlerinde manipülasyon yapacaksak propertiesin get ve set bloklarını özelleştirir ve gerekli işlemleri yazarız.
        private string AccountNo { get; set; }
        private double _balance { get; set; }
        public double Balance
        {
            get
            {
                return _balance + 10;
            }
            set
            {
                if (value != 0)
                {
                    _balance = value;
                }
                else
                {
                    _balance = 50;
                }
            }
        }
        public string GetAccountNo()
        {
            if (AccountNo == null)
            {
                return "The Account Number field is blank!";
            }
            return AccountNo;
        }
        public void SetAccountNo(string paramAccountNo)
        {
            if (!string.IsNullOrEmpty(paramAccountNo)) // Alınan parametre null veya empty değilse ekleme işlemi yapılacak.
            {
                AccountNo = paramAccountNo;
            }
        }

        /*
            Metot örneği.
            private double Balance;
            private string AccountNo;
            public double GetBalanca()
            {
                return Balance + 10;
            }
            public void SetBalanca(double paramBalanca)
            {
                if (paramBalanca != 0)
                {
                    Balance = paramBalanca;
                }
                else
                {
                    Balance = 50;
                }
            }
            public string GetAccountNo()
            {
                return AccountNo;
            }
            public void SetAccountNo(string paramAccountNo)
            {
                AccountNo = paramAccountNo;
            }
        */
    }
}