namespace DummyServiceDI.Services;

public class DummyService : IDummyService
{
    public string AnotherMessage()
    {
        return "Another message from DummyService..."; 
    }

    public string GetMessage()
    {
        return "Hello, from DummyService!"; 
    }
}