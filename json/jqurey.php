<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<style>
    </style>
<body>
    <h1>Hy mere pyare dost</h1>
    <div class="main">
        <div class="header">
            <h1>json read data</h1>
        </div>
        <div class="load-data"></div>
    </div>
</body>
<script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
<script>
    $(Document).ready(function(){
        $.ajax({
            url:"https://jsonplaceholder.typicode.com/posts",
            type:"GET",
            success:function(data){
                $.each(data,function(key,value){
                    $("#load-data").append(value.id + " <br>" + value.title + "<br>" + value.body + "<br>")
                })
            }
        })
    })
</script>



</html>
