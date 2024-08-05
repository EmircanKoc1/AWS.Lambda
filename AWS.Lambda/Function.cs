using Amazon.Lambda.Core;


[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWS.Lambda;

public class Function
{


    public Response FunctionHandler(Person person, ILambdaContext context)
    {

        if (person is { Age: < 18 })
            throw new Exception("the relevant person can not be under the age of 18!");
        return new Response()
        {
            Message = "The person has been verified !"
        };
    }



}

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}

public class Response
{
    public string Message { get; set; }
}
