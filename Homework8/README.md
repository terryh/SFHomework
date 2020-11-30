<link href="https://fonts.googleapis.com/css2?family=Fira+Code&display=swap" rel="stylesheet">
<link href="../static/main.css" rel="stylesheet" />

## Homework8 (第二組)

### 組員

* 游X翰 4094W007
* 張X文 4094W010
* 李X成 4094W011
* 何X禹 4094W012
* 黃X賢 4094W008

程式邏輯

```{.cs .numberLines}
public class StudentScore
{
    private static float _maxScore = 100.0f;
    private static float _minScore = 0.0f;
    private static int _maxStudentsLength = 500;

    public bool SetStudentScore(string id, float score, List<Student> students)
    {
        if (students.Count > _maxStudentsLength)
        {
            throw new System.ArgumentException($"The length of students not greater than {_maxStudentsLength}");
        }

        foreach (var item in students)
        {
            if (item.Id == id)
            {
                if (score < _minScore)
                {
                    throw new System.ArgumentException($"No score less than {_minScore}");
                }

                if (score > _maxScore)
                {
                    throw new System.ArgumentException($"No score greater than {_maxScore}");
                }

                
                item.Score = score;
                return true;
            }
        }
        return false;
    }
}
```

# {.pagebreak}

## 測試資料

```{.cs}
_students = new List<Student>
    {
        new Student("4094W020"),
        new Student("4094W021"),
    };
```

## Boundary value


程式邏輯功能 SetStudentScore  specification

* 設定班上學生，成績，班上學生人數，最多不超過 500 位
* 分數最高不超過 100.0 分
* 分數最低不低於 0.0 分 
* 設定成功傳回 true ，沒設定到任何學生 回傳 false，數值異常，失敗傳回 System.ArgumentException

::::columns
:::column
### test case 1

學生數量 0
```{.cs}
_students = new List<Student> {};
```
1. input values: "4094W020", 99.0
2. expected result: false
3. test program's result: false

:::
:::column

### test case 2

學生數量 2 (數量正常值)

```{.cs}
_students = new List<Student> {
        new Student("4094W020"),
        new Student("4094W021"),
};
```

1. input values: "4094W020", 99.0
2. expected result: true
3. test program's result: true
:::
::::

::::columns
:::column
### test case 3
學生數量 500 (數量上限) 

```{.cs}
List<Student> _manyStudents = new List<Student>();
for (var i = 1; i <= 500; i++)
{
    _manyStudents.Add(new Student($"ST{i:0000}"));
}
```

1. input values: "ST0100", 99.0
2. expected result: true
3. test program's result: true

:::
:::column

### test case 4

學生數量 501 (超過數量上限) 

```{.cs}
List<Student> _manyStudents = new List<Student>();
for (var i = 1; i <= 501; i++)
{
    _manyStudents.Add(new Student($"ST{i:0000}"));
}
```

1. input values: "ST0100", 99.0
2. expected result: Exception System.ArgumentException
3. test program's result: System.ArgumentException
:::
::::

# {.pagebreak}

### test case 5

學生分數 -0.1 (分數下限左邊) 

1. input values: "4094W020", -0.1
2. expected result: Exception System.ArgumentException
3. test program's result: System.ArgumentException

### test case 6

學生分數 0.0 (分數下限) 

1. input values: "4094W020", 0.0
2. expected result: true
3. test program's result: true

### test case 7

學生分數 0.1 (分數下限右邊) 

1. input values: "4094W020", 0.1
2. expected result: true
3. test program's result: true

### test case 8

學生分數 99.9 (分數上限左邊) 

1. input values: "4094W020", 99.9
2. expected result: true
3. test program's result: true

### test case 9

學生分數 100.0 (分數上限) 

1. input values: "4094W020", 100.0
2. expected result: true
3. test program's result: true

### test case 10 

學生分數 100.1 (分數上限右邊) 

1. input values: "4094W020", 100.1
2. expected result: Exception System.ArgumentException
3. test program's result: System.ArgumentException
