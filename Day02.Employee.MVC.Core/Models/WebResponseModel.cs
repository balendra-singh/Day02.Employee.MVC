using System;
using System.Collections.Generic;
using System.Text;

namespace Day02.Employee.MVC.Core.Models
{
    public class WebResponseModel<T>
    {
        public string ErrorMessage { get; set; } //response message
        public bool IsSuccess { get; set; } = true;
        public string MessageType { get; set; } = "success"; //success-> green | warning -> yellow | danger -> red
        public T ResponseData { get; set; } //model data containers
    }
}
