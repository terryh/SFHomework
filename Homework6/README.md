<link href="https://fonts.googleapis.com/css2?family=Fira+Code&display=swap" rel="stylesheet">
<link href="../static/main.css" rel="stylesheet" />

## Homework6 Mutation Test Coverage (第二組)
### 組員

* 游X翰 4094W007
* 張X文 4094W010
* 李X成 4094W011
* 何X禹 4094W012
* 黃X賢 4094W008

程式邏輯

原始
```{.cs .numberLines}
public class GoodStudentFind
{
    public string IsGoodStudent(string name, List<Student> students)
    {
        foreach (var item in students)
        {
            if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
            {
                return "YES";
            } else if (item.Name == name) 
            {
                return "NO";
            }
        }
        return "";
    }
}
```

## 測試資料

```{.cs}
/// students
_students = new List<Student>
    {
        // name, score, bmi
        new Student("Nick", 95.0f, 22.0f),
        new Student("Jack", 79.0f, 18.0f),
        new Student("John", 80.0f, 26.0f),
        new Student("Mary", 77.0f, 25.0f),
    };
```
# {.pagebreak}

## Mutation testing coverage

## 修改1
```{.cs .numberLines}
//foreach (var item in students)
foreach (var item in students.GetRange(0,1))
{
    if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
    {
        return "YES";
    } else if (item.Name == name) 
    {
        return "NO";
    }
}
return "";
```

### test case 1 

1. input values: "John"
2. expected result: "YES"
3. test program's result: "YES"
4. mutation test program's result: ""

## 修改2
```{.cs .numberLines}
foreach (var item in students)
{
    //if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
    if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score > 80.0f))
    {
        return "YES";
    } else if (item.Name == name) 
    {
        return "NO";
    }
}
return "";
```

### test case 2 

1. input values: "John"
2. expected result: "YES"
3. test program's result: "YES"
4. mutation test program's result: "NO"

# {.pagebreak}

## 修改3
```{.cs .numberLines}
foreach (var item in students)
{
    if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
    {
        //return "YES";
        return "NO";
    } else if (item.Name == name) 
    {
        return "NO";
    }
}
return "";
```

### test case 3 

1. input values: "Nick"
2. expected result: "YES"
3. test program's result: "YES"
4. mutation program's result: "NO"

## 修改4
```{.cs .numberLines}
foreach (var item in students)
{
    if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
    {
        return "YES";
    //} else if (item.Name == name) 
    } else if (item.Name != name) 
    {
        return "NO";
    }
}
return "";
```

### test case 4

此修改，無有效測試案例

1. input values: "Mary"
2. expected result: "NO"
3. test program's result: "NO"
4. mutation test program's result: "NO"

# {.pagebreak}

## 修改5
```{.cs .numberLines}
foreach (var item in students)
{
    if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
    {
        return "YES";
    } else if (item.Name == name) 
    {
        //return "NO";
        return "YES";
    }
}
return "";
```

### test case 5

1. input values: "Mary"
2. expected result: "NO"
3. test program's result: "NO"
4. mutation test program's result: "YES"

## 修改6
```{.cs .numberLines}
foreach (var item in students)
{
    if (item.Name == name && ( (item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
    {
        return "YES";
    } else if (item.Name == name) 
    {
        return "NO";
    }
}
// return "";
return "YES";
```

### test case 6

1. input values: "Eric"
2. expected result: ""
3. test program's result: ""
4. mutation test program's result: "YES"
