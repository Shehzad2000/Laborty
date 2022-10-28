
$(document).ready(function () {
    var Sno = 0;
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
function LoadTestPriceData() {
    $.ajax({
        url:,
        type: "Get",
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        succuss: function (res) {
            var html = "";
            $.each(res, function (key, item) {
                html += '<tr>';
                html += '<td>' + (Sno + 1) + '</td>';
                html += '<td>' + item.TestName + '</td>';
                html += '<td>' + item.Price + '</td>';
                html += '<td><a href="#" class="btn btn-primary" onclick="GetTestPriceByID(' + item.TestPriceID + ')"><i class="fa fa-edit"></i><span><strong> Edit</strong></span></a>&nbsp;&nbsp;<a href="#" class="btn btn-danger" onclick="Delete(' + item.TestPriceID + ')">  <i class="fa fa-trash"></i><span><strong> Delete</strong></span> </a></td>';
                html += '</tr>';
            });
            $(".tbody").html(html);
        },
        error: function (err) {
            alert(err.responseText);
        }
    });
}
function AddTestPrice() {
    var TestPriceObj = {
        TestPriceID: $('#TestPriceID').val(),
        TestID: $('#TestID').val(),
        Price: $('Price').val()
    };
    $.ajax({
        url:,
        type: "Post",
        data: JSON.stringify(TestPriceObj),
        ContentType: "application/json;charset=utf-8",
        dataType: "Json",
        succuss: function (res) {
            LoadTestPriceData();
        },
        error: function (err) {
            alert(err.responseText);
        }
    });
}
function GetTestPriceByID(ID) {
    $.ajax({
        url:,
        Type: "Get",
        ContentType: "application/json;charset=utf-8",
        datatype: "Json",
        succuss: function (res) {
            $('#TestPriceID').val(res.TestPriceID);
            $('#TestID').val(res.TestID);
            $('#Price').val(res.Price);
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
                LoadTestPriceData();
            },
            error: function (err) {
                alert(err.responseText);
            }

        })
    }
}