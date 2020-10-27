<!--<link href="https://fonts.googleapis.com/css2?family=Source+Code+Pro&display=swap" rel="stylesheet">-->
<link href="https://fonts.googleapis.com/css2?family=Fira+Code&display=swap" rel="stylesheet">
<link href="../static/main.css" rel="stylesheet" />

## Homework1 (第二組)

### 組員

* 游X翰 4094W007
* 張X文 4094W010
* 李X成 4094W011
* 何X禹 4094W012
* 黃X賢 4094W008

程式資料
``` {.cs .numberLines}
public class Student
{
    public readonly string Id;
    public readonly string Name;
    public Student(string id, string name)
    {
        Id = id;
        Name = name;
    }
}
/// ..... 略
_students = new List<Student>
{
    new Student("4094W007", "Nick"),
    new Student("4094W010", "Aven"),
    new Student("4094W011", "Totti"),
    new Student("4094W012", "Jeff"),
    new Student("4094W008", "Terry"),
};
```
程式邏輯
```{.cs .numberLines startFrom="1"}

/// 找到，返回查找的學生學號
/// 沒找到，返回空字串
public string Find(string name, List<Student> students)
{
    foreach (var item in students)
    {
        if (item.Name == name)
        {
            return item.Id;
        }
    }
    return "";
}
```

## Test Case  

程式邏輯 (line 4 ~ 14)

### test case 1 (line 4 ~ 12)

1. input values: "Terry"
2. expected result: "4094W008"
3. test program's result: "4094W008"

Line coverage:  4 5 6 7 8 9 10 11 12 

### test case 2 (line 13 ~ 14)

1. input values: "John" 
2. expected result: ""
3. test program's result: ""

Line coverage: 13 14
