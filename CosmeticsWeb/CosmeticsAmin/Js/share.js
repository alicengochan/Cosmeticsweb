function Search() {
    var form = $(".search-form");
    $.ajax({
        url: $(form).attr('action'),
        type: 'post',
        data: $(form).serialize(),
        dataType: "html",
        beforeSend: function () {
            $(".se-pre-con").show();
        },
        error: function (jqXHR, textStatus, errorThrown) {           
        },
        success: function (data) {
            $(".detail-data").html(data);          
        },
        complete: function () {
            $(".se-pre-con").hide();
        }
    });
    return false;
}