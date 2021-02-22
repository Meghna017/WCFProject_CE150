using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LibrarySystemService
{
    [DataContract]
    public class Book
    {
        //private int cid;
        //private string name;
        //private string type;
        //private string cno;
        [DataMember]
        public int BookId
        {
            get;
            set;
        }
        [DataMember]
        public string BookName
        {
            get;
            set;
        }
        
        [DataMember]
        public string ISBN
        {
            get;
            set;
        }

        [DataMember]
        public int Price
        {
            get;
            set;
        }
    }

}
