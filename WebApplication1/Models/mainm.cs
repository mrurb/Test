using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class mainm
    {
		public user User1 { get; set; }
		public user User2 { get; set; }
		public List<user> Userlist { get; set; }
		public int Id { get; set; }

		public mainm()
		{
			Userlist = new List<user>();
		}

		public mainm(List<user> userlist)
		{
			this.Userlist = userlist;
		}
	}
}
