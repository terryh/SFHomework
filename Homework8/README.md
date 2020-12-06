<link href="https://fonts.googleapis.com/css2?family=Fira+Code&display=swap" rel="stylesheet">
<link href="../static/main.css" rel="stylesheet" />

## Homework8 Boundary Value (第二組)

程式邏輯
```{.cs .numberLines}
public class StudentScore
{
    private static int _maxScore = 100;
    private static int _minScore = 0;
    private static int _maxStudentsLength = 500;
    private static int _minStudentsLength = 1;

    public bool SetStudentScore(string id, int score, List<Student> students)
    {
        if (students.Count > _maxStudentsLength || students.Count < _minStudentsLength)
        {
            throw new System.ArgumentException($"The length of students limit from {_minStudentsLength} to {_maxStudentsLength}");
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


## 測試資料

```{.cs}
_students = new List<Student>
    {
        new Student("4094W020"),
        new Student("4094W021"),
    };
```

# {.pagebreak}

## Boundary value


程式邏輯功能 SetStudentScore  specification

* 設定班上學生，成績，班上學生人數，最少 1 位， 最多不超過 500 位
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
1. input values: "4094W020", 99
2. expected result: false
3. test program's result: false

:::
:::column

### test case 2

學生數量 1

```{.cs}
_students = new List<Student> {
        new Student("4094W020"),
};
```

1. input values: "4094W020", 99
2. expected result: true
3. test program's result: true
:::
::::


::::columns
:::column

### test case 3

學生數量 2

```{.cs}
_students = new List<Student> {
        new Student("4094W020"),
        new Student("4094W021"),
};
```

1. input values: "4094W020", 99
2. expected result: true
3. test program's result: true

:::
:::column

### test case 4
學生數量 499

```{.cs}
List<Student> _manyStudents = new List<Student>();
for (var i = 1; i < 500; i++)
{
    _manyStudents.Add(new Student($"ST{i:0000}"));
}
```

1. input values: "ST0100", 99
2. expected result: true
3. test program's result: true

:::
::::

::::columns
:::column
### test case 5 

學生數量 500

```{.cs}
List<Student> _manyStudents = new List<Student>();
for (var i = 1; i <= 500; i++)
{
    _manyStudents.Add(new Student($"ST{i:0000}"));
}
```

1. input values: "ST0100", 99
2. expected result: true
3. test program's result: true

:::
:::column

### test case 6 

學生數量 501

```{.cs}
List<Student> _manyStudents = new List<Student>();
for (var i = 1; i <= 501; i++)
{
    _manyStudents.Add(new Student($"ST{i:0000}"));
}
```

1. input values: "ST0100", 99
2. expected result: Exception System.ArgumentException
3. test program's result: System.ArgumentException

:::
::::

# {.pagebreak}

::::columns
:::column

### test case 7

學生分數 -1

1. input values: "4094W020", -1
2. expected result: Exception System.ArgumentException
3. test program's result: System.ArgumentException

:::
:::column

### test case 8 

學生分數 0

1. input values: "4094W020", 0
2. expected result: true
3. test program's result: true

:::
::::

::::columns
:::column

### test case 9

學生分數 1

1. input values: "4094W020", 1
2. expected result: true
3. test program's result: true

:::
:::column

### test case 10

學生分數 99

1. input values: "4094W020", 99
2. expected result: true
3. test program's result: true

:::
::::

::::columns
:::column

### test case 11

學生分數 100

1. input values: "4094W020", 100
2. expected result: true
3. test program's result: true

:::
:::column

### test case 12 

學生分數 101

1. input values: "4094W020", 101
2. expected result: Exception System.ArgumentException
3. test program's result: System.ArgumentException

:::
::::
