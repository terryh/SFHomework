<!--<link href="https://fonts.googleapis.com/css2?family=Source+Code+Pro&display=swap" rel="stylesheet">-->
<link href="https://fonts.googleapis.com/css2?family=Fira+Code&display=swap" rel="stylesheet">
<link href="../static/main.css" rel="stylesheet" />

## Homework2 (第二組)

### 組員

* 游X翰 4094W007
* 張X文 4094W010
* 李X成 4094W011
* 何X禹 4094W012
* 黃X賢 4094W008

::::columns

:::column

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
public string Find(string name, 
    List<Student> students)
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
:::

:::column
## Graph

<!--![alt Graph](./graph.svg) { width: 200px; }-->
<img style="width: 320px;padding: 50px;" alt="" src="./graph.svg" />
:::

::::

## Edge Coverage 

* [A B]
* [B C]
* [C D]
* [D E]
* [D F]
* [F B]
* [E G]
* [B H]

<p class="pagebreak" />

## Edge-Pair Coverage 

* [A B C]
* [A B H]
* [B C D]
* [C D E]
* [C D F]
* [D E G]
* [D F B]
* [F B C]
* [F B H]
  
## Test Paths

none loop

* [A B H]
* [A B C D E G]

loop

* [A B C D F B C D E G]
* [A B C D F B H]
