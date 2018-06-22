using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManeger.Exceptions {
    class RowNotFoundException : Exception {
        public RowNotFoundException(String mensage) : base(mensage) { }
    }
}
