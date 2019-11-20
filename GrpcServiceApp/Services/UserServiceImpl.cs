using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;

namespace GrpcServiceApp.Services
{
    public class UserServiceImpl : UserService.UserServiceBase
    {
        public override Task<AddResponse> Add(AddRequest request, ServerCallContext context)
        {
            return Task.FromResult(new AddResponse { 
                C = request.A + request.B
            });
        }
    }
}
