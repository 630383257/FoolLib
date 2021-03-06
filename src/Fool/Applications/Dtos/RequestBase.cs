﻿using System.Linq;
using System.Runtime.Serialization;
using Fool.Exceptions;
using Fool.Validations;

namespace Fool.Applications.Dtos {
    /// <summary>
    /// 请求参数
    /// </summary>
    [DataContract]
    public abstract class RequestBase : IRequest {
        /// <summary>
        /// 验证
        /// </summary>
        public virtual ValidationResultCollection Validate() {
            var result = DataAnnotationValidation.Validate( this );
            if( result.IsValid )
                return ValidationResultCollection.Success;
            throw new Warning( result.First().ErrorMessage );
        }
    }
}
