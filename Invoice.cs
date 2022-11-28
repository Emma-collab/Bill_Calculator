namespace Bill_Calculator
{
    class Invoice
    {
        private int _waterused;
        private double _total;
        private double _potablecost;
        private double _wastewatercost;
        private double vat;


        public Invoice()
        {
           Waterused = waterused;
           Potablecost = potablecost;
           Wastewatercost = wastewatercost;
           Vat = vat;
           Total = total;


int waterused,double potablecost,double wastewatercost,double vat,double total


           
        }

        public int Waterused
        {
            get { return _waterused; }
            set
            {

                if (value >= 0 && this.Waterused <= 5)
                    _waterused = value ;

                else if (value >= 5 && this.Waterused <= 15)
                    _waterused = value ;

                else if (value >= 15 && this.Waterused <= 25)
                    _waterused = value ;

                else if (value >= 25 && this.Waterused <= 40)
                    _waterused = value ;

                else if (value >= 40)
                    _waterused = value ;


            }
        }

            public double DomesticPrice
        {
            get { return _potablecost; }
            set
                {if(_waterused >= 0 && _waterused <= 5)
                    DomesticPrice = (_waterused * 3.60) + (_waterused * 0.65) ;

                    

        }
        } }
    
    }

     

    




