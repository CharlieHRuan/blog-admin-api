using Microsoft.AspNetCore.Mvc;

namespace blog_admin_api.Models
{
    public class CommonResponse
    {
        public bool Successed { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public int StatusCode { get; set; } = 200;
    }
}
