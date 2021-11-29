using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace _57Block.Music.Infrastructure.Exceptions
{
    public class MusicApiException : Exception
    {
        public HttpStatusCode httpStatus { get; set; }

        public MusicApiException(HttpStatusCode httpStatusCode) :
            base(HttpMessage(httpStatusCode))
        { }

        private static string HttpMessage(HttpStatusCode httpCode) => httpCode switch
        {
            HttpStatusCode.Conflict => "The email is already registered.",
            HttpStatusCode.NotFound => "The user can not be found.",
            _ => "Music API - 57Blocks - Internal Error"
        };
    }
}
