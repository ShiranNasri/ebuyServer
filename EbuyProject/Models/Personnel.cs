using System.ComponentModel.DataAnnotations;

namespace EbuyProject.Models
{
	public class Personnel
	{
		[Key]
		public int UserId { get; set; }
		public string LoginName { get; set; }
		public string Password { get; set; }
		public UserType UserType { get; set; }
	}

	public enum UserType
	{
		Marketing, Financial, Administrator
	}
}