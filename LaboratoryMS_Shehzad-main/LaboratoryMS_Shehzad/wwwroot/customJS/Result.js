$(document).ready(function () {
    var Sno = 0;
    LoadResultDate();
});
function LoadTestData() {
    $.ajax({
        url:,
        type: "Get",
        contentType: "application/json;charset=utf-8",
        dataType: "JSON",
        success: function (res) {
            var html = '';
            html += '<select id="ddl_Test" class="form-control">';
            $.each(res, function (key, item) {
                html += '<option value="' + item.TestID + '">' + item.TestName + '</option>';
            })
            html += '</select>';
            $('.Test').html(html);
        },
        error: function (err) {
            alert(err.responseText);
        }
    })
}

function LoadResultData() {
    $.ajax({
        url:,
        type: "Get",
        ContentType: "application/json;charset=utf-8",
        DataType: "JSON",
        success: function (res) {
            var html = "";
            $.each(res, function (key, item) {
                var html = "";
                html += '<tr>';
                html += '<td>' + (Sno + 1) + '</td>';
                html += '<td>' + item.TestName + '</td>';
                html += '<td>' + item.RecieptID + '</td>';
                html += '<td>' + item.ResultValue + '</td>';
                html += '<td>' + item.ResultDate + '</td>';
                html += '<td><a href="#" class="btn btn-primary" onclick="GetResultByID(' + item.ResultID + ')"><i class="fa fa-edit"></i><span><strong> Edit</strong></span></a>&nbsp;&nbsp;<a href="#" class="btn btn-danger" onclick="Delete(' + item.ResultID + ')">  <i class="fa fa-trash"></i><span><strong> Delete</strong></span> </a></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (err) {

        }
    });
}
function AddResult() {
    var ResultObj = {
        ResultID: $('#ResultID').val(),
        TestID: $('#TestID').val(),
        RecieptID: $('#RecieptID').val(),
        ResultValue: $('#ResultValue').val(),
        ResultDate: $('#ResultDate').val()
    };
    $.ajax({
        url:,
        Type: "Post",
        Data: JSON.stringify(ResultObj),
        contentType: "application/json;charset=utf-8",
        DataType: "Json",
        success: function (res) {
            LoadResultData();
        },
        error: function (err) {
            alert(err.responseText);
        }
    })
}
}
function GetResultByID(ID) {
    $.ajax({
        url:,
        Type: "Get",
        ContentType: "application/json;charset=utf-8",
        DataType: "JSON",
        success: function (res) {
            $('#ResultID').val(res.ResultID);
            $('#TestID').val(res.TestID);
            $('#RecieptID').val(res.RecieptID);
            $('#ResultValue').val(res.ResultValue);
            $('#ResultDate').val(res.ResultDate);
        },
        error: function (err) {
            alert(err.responseText);
        }
    });
}
function Delete(ID) {

    if (Confirm("Really you want to delete this item?")) {
        $.ajax({
            url:,
            type="post",
            ContentType: "application/json;charset=utf-8",
            DataType="Json",
            success: function (res) {
                LoadResultData();
            },
            error: function (err) {
                alert(err.responseText);
            }
        })
    }