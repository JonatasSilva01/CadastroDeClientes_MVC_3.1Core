using System;
using System.Collections.Generic;

namespace Business
{
    public class Base
    {
        public Base() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime Data { get; set; }


        //List<Base> BaseList()
        //{
        //    var list = new List<Base>();
        //    return list;
        //}
    }
}
