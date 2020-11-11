<link href="https://fonts.googleapis.com/css2?family=Fira+Code&display=swap" rel="stylesheet">
<link href="../static/main.css" rel="stylesheet" />

## Homework6 (第二組)

### 組員

* 游X翰 4094W007
* 張X文 4094W010
* 李X成 4094W011
* 何X禹 4094W012
* 黃X賢 4094W008

程式邏輯

::::columns

:::column

原始
```{.cs .numberLines}
public string IsGoodStudent(string name, List<Student> students)
{
    foreach (var item in students)
    {
        if (item.Name == name && (
            (item.Bmi >= 18.5f && item.Bmi < 24.0f) || 
            item.Score >= 80.0f))
        {
            return "YES";
        } else if (item.Name == name) 
        {
            return "NO";
        }
    }
    // no found
    return "";
}
```
:::
:::column
修改
```{.cs .numberLines}
public string IsGoodStudent(string name, List<Student> students)
{
    foreach (var item in students)
    {
        if (item.Name == name && (
            (item.Bmi >= 18.5f && item.Bmi < 24.0f) || 
            item.Score > 80.0f))
        {
            return "YES";
        } else if (item.Name == name) 
        {
            return "NO";
        }
    }
    // no found
    return "";
}
```
:::
::::

## Mutation testing coverage

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

/// 原始
if (item.Name == name && ((item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score >= 80.0f))
/// 修改
if (item.Name == name && ((item.Bmi >= 18.5f && item.Bmi < 24.0f) || item.Score > 80.0f))
```
<p class="pagebreak" />

## Mutation testing coverage

### test case 1 

1. input values: "John"
2. expected result: "YES"
3. test program's result: "YES"

### test case 2 

1. input values: "John"
2. expected result: "NO"
3. test program's result: "NO"
