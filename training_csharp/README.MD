CSharp Training Materials
===

如何使用这个项目
---

项目目录

* doc 包含课程PPT
* demo 课程PPT中相关的演示代码和PPT中涉及的测试程序。
* src 课后测试项目基本框架，**参加培训的同学需要基于此项目完成要求的功能**。
* sql 创建课后测试项目所需要的数据库表的脚本参考，本页靠后的部分也有此脚本


---

课后测试(SimpleORM)
---
前提条件

 - Visual Studio 2012
 - TestDriven.NET Personal

基于项目代码中的SqlHelper实现一个简单的ORM组件，支持下面的功能:

```csharp
// 通过指定条件从数据库表中获取记录，并映射为一个实体列表，实体类型通过TEntity指定。
List<TEntity> Query<TEntity>(string condition);

// 根据实体创建一条数据库表记录，并返回数据库表的主键 
int Create<TEntity>(TEntity entity);

// 根据实体更新一条数据库记录，除主键以外的其它字段均可更新，返回受影响的记录条数。 
int Update<TEntity>(TEntity entity);

// 根据实体删除一条数据库记录，实体中必须包含有效的主键值，返回受影响的记录条数。
int Delete<TEntity>(TEntity entity); 
```

注意
> * 实现解决方案中标记了TODO的所有方法，如果需要可以自行增加类定义。
> * 考虑用单元测试验证实现的正确性。(NUnit)


提示: 思考下面的问题

> * 如何表示实体类型与表的关系?
> * 如何在实体类型定义中标识一个主键属性?
> * 以字符串作为查询条件传入存在什么问题，如何避免问题?

---

SqlHelper的使用可以参考SimpleORM.ConsoleTest项目中的[代码](http://trgit2/intern/training_csharp/blob/master/src/SimpleORM.ConsoleTest/Program.cs)。

数据库连接信息:
    
    Server=SCMISBIZTALK01;UID=intern;Password=Th!sls@l0ngPWD;Database=CSharpTraining

该账号有权限在CSharpTraining库中创建表，请各位同学创建自己名字的表，以免测试时相互影响。

创建表的脚本可以参考:

    USE [CSharpTraining]
    GO
    

    CREATE TABLE [dbo].[YOUR TABLE NAME HERE!](
        [ID] [int] IDENTITY(1,1) NOT NULL,
        [Name] [nvarchar](50) NOT NULL,
        [InDate] [datetime] NOT NULL,
        [InUser] [varchar](15) NOT NULL,
        [LastEditDate] [datetime] NULL,
        [LastEditUser] [varchar](15) NULL,
    CONSTRAINT [PK_YOUR TABLE NAME HERE!] PRIMARY KEY CLUSTERED 
    (
        [ID] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]

    GO

