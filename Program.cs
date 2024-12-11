// 1. 계산기 프로그램

//내용: 사용자가 두 개의 숫자를 입력하고, 더하기, 빼기, 곱하기, 나누기를 수행하는 프로그램.

//학습 포인트:

//변수와 데이터 타입, 조건문 (if, switch)

//사용자 입력과 출력 (Console.ReadLine, Console.WriteLine)
using System;
using System.Collections.Generic;

static void CalculatorProgram()
{
    Console.WriteLine("간단한 사칙연산 프로그램입니다.");
    Console.WriteLine("숫자를 두 개 입력하세요.");
    int firstnum = int.Parse(Console.ReadLine());
    int secondnum = int.Parse(Console.ReadLine());

    int result;
    while (true)
    {
        Console.WriteLine("입력한 두 숫자를 어떻게 처리할까요?");
        Console.WriteLine("1 : 더하기, 2 : 빼기, 3 : 곱하기, 4 : 나누기");
        Console.WriteLine("해당하는 숫자를 입력하세요.");
        result = int.Parse(Console.ReadLine());

        if (result >= 1 && result <= 4)
        {
            break; // 유효한 입력인 경우 반복문 종료
        }
        else
        {
            Console.WriteLine("1 ~ 4 까지의 숫자를 입력하세요."); // 유효하지 않은 입력인 경우 다시 입력
        }
    }
    switch (result)
    {
        case 1:
        Console.WriteLine("두 숫자를 더한 값은 " + (firstnum + secondnum));
        break;
        case 2:
        Console.WriteLine("두 숫자를 뺀 값은 " + (firstnum - secondnum));
        break;
        case 3:
        Console.WriteLine("두 숫자를 곱한 값은 " + (firstnum * secondnum));
        break;
        case 4:
        Console.WriteLine("두 숫자를 나눈 값은 " + (firstnum / secondnum));
        break;
    }
}

//2. 간단한 숫자 맞추기 게임

	//내용: 프로그램이 무작위 숫자(1~100)를 생성하고, 사용자가 숫자를 맞출 때까지 힌트를 제공하는 게임.

	//학습 포인트:

		//랜덤 숫자 생성 (Random 클래스), 조건문과 반복문 활용

		//사용자 입력 유효성 검증

static void RandomNumberGuessGame()
{
    Random random = new Random();       // 인스턴스 생성 및 초기화
        
    
    int targetNumber = random.Next(1, 100); // 타겟넘버에 1부터 100까지의 숫자 중 랜덤하게 한 숫자를 담음
    int userGuess = 0;                      // userGuess 변수 초기화
        
    Console.WriteLine("숫자 맞추기 게임에 오신 것을 환영합니다!");
    Console.WriteLine("1부터 100 사이의 숫자를 맞춰보세요.");

    
    while (userGuess != targetNumber)       // 유저게스가 타겟넘버와 다르거나 같을 때
    {
        Console.Write("숫자를 입력하세요: ");
        string input = Console.ReadLine();      // 인풋에 유저 입력값 담기
        // == int input = int.Parse(Console.ReadLine());
        
        if (!int.TryParse(input, out userGuess))    // 인트로 파싱한 인풋을 유저게스에 할당
        {
            Console.WriteLine("유효한 숫자를 입력해주세요.");
            continue;                               // 유저가 유효한 숫자를 입력할 때 까지 계속 while문 진행
        }

        
        if (userGuess < 1 || userGuess > 100)       // 유저게스가 1보다 작거나 100보다 클 때
        {
            Console.WriteLine("숫자는 1부터 100 사이여야 합니다.");
            continue;                               // 유저가 유효한 숫자를 입력할 때 까지 계속 while문 진행
        }

        
        if (userGuess < targetNumber)               // 유저게스가 타겟넘버보다 작을 때
        {
            Console.WriteLine("더 큰 숫자입니다.");     // 힌트
        }
        else if (userGuess > targetNumber)          // 유저게스가 타겟넘버보다 클 때
        {
            Console.WriteLine("더 작은 숫자입니다.");    // 힌트
        }
        else                                        // 유저게스 == 타겟넘버
        {
            Console.WriteLine("정답입니다! 축하합니다!"); // 정답 문구 출력
        }
    }   
}

//3. 성적 계산 프로그램

	//내용: 여러 학생의 이름과 점수를 입력받아 평균 점수를 계산하고, 최고 점수와 최저 점수를 표시하는 프로그램.

	//학습 포인트:

		//배열 또는 리스트 사용 (int[], List<int>)

		//기본적인 연산과 통계 계산

		//문자열 처리

static void ScoreProgram()
{
    List<string> studentNames = new List<string>();     // 학생 이름을 받는 리스트 선언
    List<int> studentScores = new List<int>();          // 학생 점수를 받는 리스트 선언

    string input = string.Empty;                        // 입력값을 받을 인풋 변수 선언(스트링.엠티)로 초기화
    while (true)                                        // 값이 참일 때
    {
        Console.Write("학생 이름을 입력하세요(입력을 끝내려면 '종료' 입력) : ");
        input = Console.ReadLine();                     // 학생 이름 입력받기
        if (input == "종료") break;                      // "종료"키워드 입력 시 반복문 탈출

        studentNames.Add(input);                        // 인풋에 학생 이름 리스트 대입

        Console.Write("점수를 입력하세요 : ");
        int score = int.Parse(Console.ReadLine());      // 점수 입력 받을 변수 선언(인트로 파싱해주기)
        while (score < 0 || score > 100)                // 스코어가 0보다 작거나 100보다 크면
        {
            Console.WriteLine("유효한 점수를 입력하세요. (0~100)"); // 유효한 점수를 입력할 때 까지 반복문 실행
        }
        studentScores.Add(score);                       // 스코어에 학생 점수 리스트 대입
    }

    if (studentScores.Count > 0)                        // 리스트에 저장된 요소의 개수가 0보다 클 경우
    {
        int totalScore = 0;                             // 총점 초기화
        int maxScore = int.MinValue;                    // 최고 점수 초기화 (민밸류로 초기화하면 어떤 점수든 민밸류보다 크기 때문에 민밸류로 초기화)
        int minScore = int.MaxValue;                    // 최저 점수 초기화 (맥스밸류로 초기화하면 어떤 점수든 맥스밸류보다 작기 때문에 맥스밸류로 초기화)

        foreach(int score in studentScores)             
        {
            totalScore += score;                        // 총점 계신
            if(score > maxScore) maxScore = score;      // 최대값 계산
            if(score < minScore) minScore = score;      // 최소값 계산
        }
        double averageScore = (double)totalScore / studentScores.Count; // 정수형 인트가 아닌 실수형 더블로 평균 점수 구하기

        System.Console.WriteLine($"학생 수 : {studentNames.Count}");     // 학생 수 출력
        System.Console.WriteLine($"평균 점수 : {averageScore:F2}");      // 평균점수 소숫점 2째자리까지 출력
        System.Console.WriteLine($"최고 점수 : {maxScore}");             // 최고점수 출력
        System.Console.WriteLine($"최저 점수 : {minScore}");             // 최저점수 출력
    }
}


//4. 간단한 주소록 관리 프로그램

	//내용: 사용자가 이름과 전화번호를 입력하고 이를 저장하거나 검색, 삭제할 수 있는 프로그램.

	//학습 포인트:

		//컬렉션 (Dictionary 또는 List)

		//간단한 CRUD 작업

		//프로그램 구조화 (메서드 분리)



//5. 간단한 시계 프로그램

	//내용: 현재 시간을 표시하고, 몇 초 뒤의 시간을 계산하거나 특정 포맷으로 출력.

	//학습 포인트:

		//날짜와 시간 처리 (DateTime 클래스)

		//문자열 포맷팅 (ToString 메서드)



// 컬렉션 연습
List<int>list = new List<int>();
for (int i = 0; i < 5; i++)
{
    list.Add(i);
}
foreach(int element in list)
{
    System.Console.WriteLine(element + " ");
}

//Stack 이해
Stack<int> stack = new Stack<int>();
stack.Push( 1 );
stack.Push( 2 );
stack.Push( 3 );

int a = (int)stack.Pop();
System.Console.WriteLine(a);

//yield 이해
static IEnumerable<int> GetNumber()
{
    yield return 10;
    yield return 20;
    yield return 30;
}
static void Main(string[] args)
{
    foreach (int num in GetNumber())
    {
        System.Console.WriteLine(num);
    }
}