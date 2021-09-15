using System;

namespace C_
{

    public class Produto
    {

        private string _nome;

        public string Nome {
            get {return _nome;}
            set {
                if(value != null && value.Length > 0)
                {
                    _nome = value;
                }
            }
        }

    }

}