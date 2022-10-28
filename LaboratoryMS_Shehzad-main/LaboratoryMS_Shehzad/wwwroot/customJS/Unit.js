$(document).ready(function () {
    var Sno = 0;
    LoadUnitData();
});
function LoadUnitData() {
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
                html += '<td>' + item.UnitID + '</td>';
                html += '<td>' + item.UnitName + '</td>';
                html += '<td><a href="#" class="btn btn-primary" onclick="GetUnitByID(' + item.UnitID + ')"><i class="fa fa-edit"></i><span><strong> Edit</strong></span></a>&nbsp;&nbsp;<a href="#" class="btn btn-danger" onclick="Delete(' + item.UnitID + ')">  <i class="fa fa-trash"></i><span><strong> Delete</strong></span> </a></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (err) {
            alert(err.responseText);
        }
    });
}
function AddUnit() {
    var UnitObj = {
        UnitID: $('#UnitID').val(),
        UnitName: $('#UnitName').val()
    };
    $.ajax({
        url:,
        Type: "Post",
        Data: JSON.stringify(UnitObj),
        contentType: "application/json;charset=utf-8",
        DataType: "Json",
        success: function (res) {
            LoadUnitData();
        },
        error: function (err) {
            alert(err.responseText);
        }
    })
}
}
function GetUnitByID(ID) {
    $.ajax({
        url:,
        Type: "Get",
        ContentType: "application/json;charset=utf-8",
        DataType: "JSON",
        success: function (res) {
            $('#UnitID').val(res.UnitID);
            $('#UnitName').val(res.UnitName);
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
                LoadUnitData();
            },
            error: function (err) {
                alert(err.responseText);
            }
        })
    }