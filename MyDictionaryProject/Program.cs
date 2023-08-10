namespace MyDictionaryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("a", 1);
            myDictionary.Add("b", 2);
            myDictionary.Add("c", 3);
            myDictionary.Add("d", 4);

            Console.WriteLine(myDictionary);
        }
    }


    class MyDictionary<TKey, TValue>
    {
        TKey[] _key;
        TValue[] _value;
        TKey[] _tempKey;
        TValue[] _tempValue;

        //constructor   Yapıcı Method
        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempKey = _key;
            _tempValue = _value;

            _key = new TKey[_key.Length + 1];
            _value = new TValue[_key.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }
            _key[_key.Length - 1] = key;

            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }
            _value[_value.Length - 1] = value;
        }

        public override string ToString()
        {
            string result = "MyDictionary Content:\n";

            for (int i = 0; i < _key.Length; i++)
            {
                result += $"Key: {_key[i]}, Value: {_value[i]}\n";
            }
            return result;
        }
    }
}