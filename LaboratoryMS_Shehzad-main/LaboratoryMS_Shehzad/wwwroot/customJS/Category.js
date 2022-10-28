var BaseHostedURL;

$(document).ready(function () {
    
    var Sno = 0;
    $.get(window.location.origin + "/account/GETAPIUrl", function (data, status) {
        
        BaseHostedURL = data;
    });
    LoadCategoryData();
});
function LoadCategoryData() {
    $.ajax({
        url: BaseHostedURL+"Category/allCategory",
        type: "Get",
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        succuss: function (res) {
            var html = "";
            $.each(res, function (key, item) {
                html += '<tr>';
                html += '<td>' + (Sno + 1) + '</td>';
                html += '<td>' + item.CategoryName + '</td>';
                html += '<td><a href="#" class="btn btn-primary" onclick="GetCatgoryByID(' + item.CatID + ')"><i class="fa fa-edit"></i><span><strong> Edit</strong></span></a>&nbsp;&nbsp;<a href="#" class="btn btn-danger" onclick="Delete(' + item.CatID + ')">  <i class="fa fa-trash"></i><span><strong> Delete</strong></span> </a></td>';
                html += '</tr>';
            });
            $(".tbody").html(html);
        },
        error: function (err) {
            alert(err.responseText);
        }

    });
}
function AddCategory() {
    debugger;
    var CatObj =  {
        CatID: $('#CatID').val(),
        CategoryName: $('#CategoryName').val()
    };
    $.ajax({
        url: BaseHostedURL + "Category/addCategory",
        type: "Post",
        data: CatObj,
        ContentType: "application/json;charset=utf-8",
        dataType: "Json",
        succuss: function (res) {
            alert(res);
            LoadCategoryData();
        },
        error: function (err) {
            alert(err.responseText);
        }
    });
}
function GetCatgoryByID(ID) {
    $.ajax({
        url: BaseHostedURL + "Category/categoryByID",
        Type: "Get",
        ContentType: "application/json;charset=utf-8",
        datatype: "Json",
        succuss: function (res) {
            $('#CatID').val(res.CatID);
            $('#CategoryName').val(res.CategoryName);
        },
        error: function (err) {
            alert(err.responseText);
        }
    });
}
function Delete(ID) {
    if (Confirm("Really you want to delete this item?")) {
        $.ajax({
            url: BaseHostedURL + "Category/deleteCategory",
            type: "post",
            ContentType: "application/json;charset=utf-8",
            DataType: "Json",
            success: function (res) {
                LoadCountryData();
            },
            error: function (err) {
                alert(err.responseText);
            }
            

        })
    }
}