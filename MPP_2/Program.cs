using MPP_2.MyFaker;
using MPP_2.MyGenerator;

FakerConfig config = new FakerConfig();
Faker f = new Faker();
var s = f.Create<TestClass>();

public class Gen: ICustomGenerator<int>
{

    public int Generate()
    {
        return 5;
    }
}

public class TestClass {

    public int a;
    public int b;
    private int t;
    private int y;
    public FirstClass cFirst;//cA

    public int c { get; private set; }
    public int d { private get; set; }
    private int dg {  get; set; }

    public List<int> list;
    public int aasd() { return 5; }
    public TestClass(int a) { this.a = a; }
    public TestClass() { }
}

public class FirstClass
{

    public int a;
    public int b;

    public FirstClass() { }
}

public class SecondClass
{

    public int a;
    public int b;
    public SecondClass() { }
}