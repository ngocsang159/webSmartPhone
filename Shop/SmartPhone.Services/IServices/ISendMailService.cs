using SmartPhone.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone.Services
{
    public interface ISendMailService
    {
    
            Task SendMail(MailContent mailContent);

            //Task SendEmailAsync(string email, string subject, string htmlMessage);
     
    }
}
