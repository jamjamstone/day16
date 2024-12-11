namespace day16
{
    /*
    class Reward
    {
        int _gold;
        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }
    }


    class Enemy
    {
        static Reward _reward = new Reward();//정적 필드
        static int _createCount;//정적으로 할당되고 모두가 공유하는 값이 된다.
        int _id;
        int _health;
        static public Reward Reward// 정적 프로퍼티
        {
            get
            {
                if (_reward == null)
                {
                    _reward = new Reward();
                   
                }
                return _reward;
            }
            set
            {
                _reward = value;
            }
        }
        const int MaxEnergy = 100;// 
        public int UniqueId
        {
            get { return _id; }
            set { _id = value; }
        }
        public Enemy()
        {
            if (_reward == null)
            {
                _reward = new Reward();
            }
            //_reward = new Reward();
            //_createCount++;
            //UniqueId=_createCount;
        }
        public static int CreateCount//static이 붙었기 때문에 클래스명인 Enemy를 사용
        {
            get { return _createCount; }//static이 아니기 때문에 반환 안됨
            set { _createCount = value; }
        }
        public void IncreaseCreateCount()
        {
            _createCount++;
        }
        public void ShowCreateCount()
        {
            Console.WriteLine(_createCount);
        }

    }

    partial class Army
    {
        Ship[] _ships;
        public Army()
        {
            Ship[] _ships = new Ship[10];

        }
        public void SetShipByIndex(int index, Ship ship)
        {
            _ships[index] = ship;
        }
    }
    class Ship
    {
        int _hp;
        string _name;


        public void SetHp(int hp)
        {
            _hp = hp;
        }
        public Ship(string name = "Battle Ship")
        {
            _name = name;
        }
        public Ship(int hp)
        {
            {
                _hp = hp;
            }

        }
    }*/
    /*
    struct intAlike
    {
        public static void ParseAlike()
        {
            Console.WriteLine("int.parse와 비슷하다");
        }
    }

    class StaticFunc
    {
        int _nonStaticNum = 5;
        static int _staticNum = 10;

        static public void PrintNum()//정적 메소드
        {
           // Console.WriteLine("비정적 정수값은 : "+_nonStaticNum);// 정적 메소드에는 정적 상수만 진입 가능인듯
            Console.WriteLine("정적 정수값은: "+_staticNum);
        }
        public static void IncreaseAndPrintStaticNum() 
        { 
            _staticNum++;
            PrintNum();
            int a = 0;//정적 메소드에서 지역변수는 static으로 선언하지 않아도 된다.
            Random random = new Random();   
            //PrintNormalNum();// 정적 메소드에 동적메소드 호출 불가능
        }
        public void PrintNormalNum()//정적 메소드
        {
            Console.WriteLine("비정적 정수값은 : "+_nonStaticNum);// 정적 메소드에는 정적 상수만 진입 가능인듯
            Console.WriteLine("정적 정수값은: " + _staticNum);
        }


    }*/
    //정적 클래스는 const, static만 보유 가능
    static class MyMath
    {
        static int a;
        public const float PI = 3.14f;
        static readonly int dontknowYet;//readonly와 const차이 블로그 작성
        static public int DoubleThenumber(int _toDouble)
        {
            return _toDouble * 2;
        }
        static MyMath()// 생성자 한번 호출되고 상주 따라서 정적 클래스 생성자는 사용이 복잡하다
        {
            Console.WriteLine("create");
        }
        public static void doSome()
        {
            Console.WriteLine("lol");
        }


    }
    /// static => 필요할 때 기능 쓰기, 플레이어 정보  <summary>
    /// static 사용할 때는 충분히 고려하고 사용하기 디버그에 악영향을 미칠 가능성 있음
    /// 
    /// </summary>

    class Program
    {
        // 오버로딩: 같은 이름을 쓰되 인자값만 다르면 추가적으로 사용 가능한 것
        static void Main(string[] args)
        {
            int myNum = 4;
            int doubleNum=MyMath.DoubleThenumber(myNum);
            Console.WriteLine(MyMath.PI);
            MyMath.doSome();
            MyMath.doSome(); MyMath.doSome(); MyMath.doSome();





            /*
            StaticFunc test = new StaticFunc();
            StaticFunc.PrintNum();
            intAlike.ParseAlike();//구조체에 함수를 넣고 사용가능
            int.Parse("");
            */
            /*
            //Ship ship = new Ship();
            Army myTroop = new Army();
            myTroop.SetShipByIndex(0, new Ship(15));
            */
            /*
            Enemy hunter1 = new Enemy();
            Enemy hunter3 = new Enemy();
            Enemy hunter2 = new Enemy();
            hunter1.ShowCreateCount();
            hunter2.ShowCreateCount();
            hunter3.ShowCreateCount();
            Console.WriteLine(hunter1.UniqueId);
            Console.WriteLine(hunter2.UniqueId);
            Console.WriteLine(hunter3.UniqueId);
            Console.WriteLine(Enemy._createCount);//static이 붙으면 별도의 객체가 아니라 클래스 명을 통해서 접근 가능
            ///static은 힙과 스택이 아닌 static 만의 공간이 따로 존재
            ///Data 영역에 존재한다.
            /**
             
            hunter2.IncreaseCreateCount();
            hunter1.ShowCreateCount();
            hunter2.ShowCreateCount();
            hunter3.ShowCreateCount();*/
            /*
            Enemy enemy = new Enemy();
            Enemy.Reward.Gold = 25000;
            Console.WriteLine(Enemy.Reward.Gold);
            Enemy enemy2 = new Enemy();
            //Enemy._reward.Gold = 25000;
            Console.WriteLine(Enemy.Reward.Gold);*/
        }
    }
}
