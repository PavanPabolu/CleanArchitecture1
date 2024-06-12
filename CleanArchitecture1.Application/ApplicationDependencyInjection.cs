using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture1.Application
{
    public static class ApplicationDependencyInjection
    {
        // Nuget: MediatR package - for usecases
        // Nuget: FluentValidation.DependencyInjectionExtension package - for DI in class library
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(ApplicationDependencyInjection).Assembly;

            //services.AddMediatR(config => config.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
//https://www.youtube.com/watch?v=fe4iuaoxGbA&list=PLYpjLpq5ZDGv370qMB4PLF-PlGdBhP0PA
/*
what is the use of mediatR library used for?
MediatR optimizes code organization and promotes cleaner architecture by mediating communication between various parts of .NET applications.
1.Decoupling Components: It simplifies separation of concerns by facilitating communication between components without direct dependencies [3].
2.CQRS Implementation: It supports Command Query Responsibility Segregation (CQRS) by enabling easy command and query handling [5].
3.Flexibility and Simplification: Developed by Jimmy Bogard, it offers simplicity and flexibility in managing communication flow within applications [2].



**MediatR** is a powerful library in the .NET ecosystem that simplifies communication between components within an application. Here are some of its key use cases:

1. **CQRS (Command Query Responsibility Segregation) Pattern**:
   - MediatR aids in implementing the CQRS pattern by decoupling in-process messaging.
   - It allows you to separate commands (write operations) from queries (read operations).
   - By using MediatR, you can handle commands and queries independently, making your codebase more maintainable.

2. **Dependency Injection (DI) Constructor Explosion**:
   - In large MVC controllers, managing multiple dependencies can become challenging.
   - MediatR helps address this issue by centralizing request handling.
   - Instead of injecting numerous dependencies directly into your controller constructors, you can use MediatR to handle requests and dispatch them to the appropriate handlers¹.

3. **MediatR Pipelines**:
   - MediatR pipelines allow you to intercept requests and responses.
   - Use cases for pipelines include logging relevant information, implementing caching, and more³.

4. **Microservices Architecture**:
   - MediatR can be useful in a microservices architecture.
   - It enables decoupled communication between different services, promoting better isolation and maintainability⁴.

Remember that while MediatR offers benefits, it's essential to consider your specific project requirements and choose the right approach for your environment¹. 🚀

Source: Conversation with Copilot, 6/12/2024
(1) c# - MediatR when and why I should use it? - Stack Overflow. https://stackoverflow.com/questions/50663501/mediatr-when-and-why-i-should-use-it.
(2) C# .NET 8 — MediatR Pipelines. How to use MediarR Pipelines in C# .NET .... https://medium.com/@gabrieletronchin/c-net-8-mediatr-pipelines-edcc9ae8224b.
(3) Mediatr is a popular library for implementing the mediator pattern in .NET. https://medium.com/@tranan.aptech/mediatr-is-a-popular-library-for-implementing-the-mediator-pattern-in-net-bd6c4611303d.
(4) Mastering Mediator Pattern Implementations Part 1. https://softwaremind.com/blog/mastering-mediator-pattern-implementations-part-1/.
(5) Implementing Clean Architecture — To use or not to use MediatR?. https://medium.com/@plainionist/implementing-clean-architecture-to-use-or-not-to-use-mediatr-c16e93766de9.

 */