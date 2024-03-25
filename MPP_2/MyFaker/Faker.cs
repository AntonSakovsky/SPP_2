using MPP_2.MyGenerator;

namespace MPP_2.MyFaker
{
    public class Faker : IFaker
    {
        private readonly FakerConfig? config;
        public T Create<T>() {
            Type type = typeof(T);
            var generatorsDictionary = config == null ? null : config.GetClassConfig(type);
            var obj = Generators.GenerateDTO(type, generatorsDictionary);
            return (T)obj;
        }

        public Faker() => this.config = null;

        public Faker(FakerConfig config) => this.config = config;
    }
}
