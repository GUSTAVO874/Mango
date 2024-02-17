namespace Mango.Services.CouponAPI.Models.Dto
{
    //para pasar un objeto común y personalizado por la api
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
