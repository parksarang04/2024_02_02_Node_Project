const express=require("express");
const app = express();

let users = [
    {id : 0, data: "User 1"}
];

app.use(express.json());

app.get('/', (req, res) => {

    let result = {
        cmd : -1,
        message : 'Hello World!'
    };

    res.send(result);
})

app.post('/userdata', (req, res) =>{

    const {id, data} = req.body;

    console.log(id, data);


    let result = {
        cmd : -1,
        message : ''
    };

    let user = users.find(x=>x.id == id);

    if(user === undefined)          //유저 아이디가 없음 (신규 등록)
    {
        users.push({id,data});
        result.cmd = 1001;
        result.message = '유저 신규 등록.'
    }
    else
    {
        console.log(id, user.data);
        user.data = data;
        result.cmd = 1002;
        result.message = '데이터 갱신'
    }
    res.send(result);
})





app.listen(3000, function(){                            //3000포트에서 입력을 대기 한다.
    console.log('Example app listening on port 3000');      
});

