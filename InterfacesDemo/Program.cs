// See https://aka.ms/new-console-template for more information



IWorker[] workers = new IWorker[3]
    {
    new Worker(),
    new Manager(),
    new Robot()
    };

foreach (var worker in workers)
{
    worker.Work();
}

IEeat[] eeats = new IEeat[2]
{
    new Worker(),
    new Manager(),
};

foreach (var eeat in eeats)
{
    eeat.Eat();
}

interface IWorker
{
    void Work();
}

interface IEeat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}
class Manager : IWorker, IEeat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}


class Worker : IWorker, ISalary, IEeat
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}




