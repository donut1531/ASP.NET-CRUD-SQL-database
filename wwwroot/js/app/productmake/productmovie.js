let ProductMovieList;
let modal = document.getElementById('id01');
let CreateRes = ["บันทึกสำเร็จ","บันทึกไม่สำเร็จ","ไม่สามารถสร้างสินค้าได้"];
let UpdateRes = ["แก้ไขสำเร็จ","แก้ไขไม่สำเร็จ","ไม่สามารถแก้ไขสินค้าได้"];
let Identity = "null";
let modeApi = "Create";
let mode;

toastr.options = {
    "showDuration": 300,
}


var tbody = $('tbody');
$(document).ready(function () {

    var counter = 1;
    
    $.ajax({
        url: `${siteRootUrl}api/ProductMakes/list`,
        method: 'GET',
        async : false,
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        success: function (res) {
           ProductMovieList = res.Data
          
           len = ProductMovieList.length;
          
          
        },
        error: function (res) {
            console.log(res);
            
        }
    });
    let i = 0 ;
   
    let listMovie = "";

    while(i < len){
        
        listMovie = ProductMovieList[i];
        counter++;
        var newRow = $("<tr>");
        var cols = "";
        cols += '<td><label type = "number" id="moviecode'+counter+'" >'+listMovie['ProductMovieCode']+'</label></td>';

        cols += '<td><label type = "number" id="moviedes'+counter+'" >'+listMovie['ProductMovieDes']+'</label></td>';

       

        cols += '<td><button class ="editRow btn btn-primary " id="editbtn'+counter+'" >Edit</button></td>';
        cols += '<td><button  class ="deleteRow btn btn-danger" id="delbtn'+counter+'" >Delete</button></td>';

        // cols += '<td><input type = "number" id="moviecode'+counter+'" value = "'+listMovie['ProductMovieCode']+'"/></td>';

        // cols += '<td><input type = "text" id="moviedes '+counter+'" value = "'+listMovie['ProductMovieDesc']+'"/></td>';

        // cols += '<td><button class ="deleteRow btn-dark" id="delbtn'+counter+'" >Delete</button></td>';

        // cols += '<td><button class ="editRow btn-dark" id="editbtn'+counter+'" >Edit</button></td>';

        newRow.append(cols);

        $("#dynamictable").append(newRow);
        i++;

    }
    $("#addbtn").click(function(){
        
        $(".modal").show();
        $("#inputID").prop('disabled', false);
        $("#inputID").val('');
        $("#inputDes").val('');
     })
     $("#close").click(()=>{
        $(".modal").hide();
     })
     $(".close").click(()=>{
        $(".modal").hide();
     })
    
    
    
    $("#addrow").on("click", function (event) {
        
        
        mode = ApiSelector(modeApi);
        
        if(modeApi == "Update"){
            MovieID = Identity;
            modeApi = "Create";
        }
        
        var MovieID = $("#inputID").val();
        var MovieDes = $("#inputDes").val();
        
        
        if (MovieID == '') {
            toastr.error("You didn't fill Product Name!");
            
            
            
        }
        if (MovieDes == '') {
            toastr.error("You didn't fill Product Description!");
            
            // $("#inputID").val('');
            // $("#inputDes").val('');
        }
        if((MovieID)%1 !=0){
            toastr.error("Movie Code require Integer");
            
            return;
        }

        if (MovieID !== '' && MovieDes  !== '') {
          
             var obj = {ProductMovieCode : parseInt(MovieID)    ,ProductMovieDes : MovieDes}
             
            $.ajax({
                
                url: mode['action'],
                method : 'POST',
                data: JSON.stringify(obj),
                dataType: 'json',
                contentType: "application/json; charset=utf-8",
                success: function(response) {   
                    
                        if(response.Status.Code == 200){
                            $(".modal").hide();
                            
                           
                            toastr.success( mode.Status[0])
                            setTimeout(() => {  reloadPage(); }, 700);
                            
                            
                            
                          
                            
                            
                        }
                        else if(response.Status.Code == 400){
                            toastr.error(mode.Status[1])
                            
                        }
                        
                       
                },
                error: function(response) {

                        
                        console.log("E: ")
                        console.log(response)
                 }
            });
            
        }
    });
    $("#dynamictable").on("click", "button.editRow", function (event) {

            modeApi = "Update";
        

        
            var rowlocation = this.id;
            $(".modal").show();
            $("#inputID").prop('disabled', true);
            var thisloc = '#'+'moviecode'+parseInt(rowlocation.replace(/[^0-9.]/g, ""));
            var thisDes = '#'+'moviedes'+parseInt(rowlocation.replace(/[^0-9.]/g, ""));
            
            Identity = $(thisloc).text();
            
            $("#inputID").val(Identity);
            $("#inputDes").val($(thisDes).text());
            
       
        
        
    });
    $("#dynamictable").on("click", "button.deleteRow", function (event) {
        let text = "";
        if( confirm("Press a button!") == true){
        var rowlocation = this.id;
        var thisloc = '#'+'moviecode'+parseInt(rowlocation.replace(/[^0-9.]/g, ""));
        
        var ProductMovieCode = parseInt($(thisloc).text());
        }
        else{
           return
        }
        $.ajax({
            url: `${siteRootUrl}api/ProductMakes/Delete`,
            method: 'POST',
            data: JSON.stringify({ProductMovieCode}),
            dataType: 'json',
            contentType: "application/json; charset=utf-8",
            success: function (res) {

                    toastr.error("ลบข้อมูลสำเร็จ")
                    setTimeout(() => {  reloadPage(); }, 700);
                    
                    
               
            },
            error: function (res) {

                    toastr.error("ไม่สามารถลบข้อมูลได้")
                    setTimeout(() => {  reloadPage(); }, 700);
                   
            }
        });
    });
});

function reloadPage(){
    location.reload(true);
}

function ApiSelector(modeApi){
    var MovieCodeName = $('#inputID').val();
    var MovieDescription = $("#inputDes").val();
    console.log(MovieCodeName+" "+MovieDescription)
    if (modeApi == "Create"){
        var action = `${siteRootUrl}api/ProductMakes/Create`;
        
        var Status = CreateRes;
    } else if (modeApi == "Update") {
       
        var action = `${siteRootUrl}api/ProductMakes/Update`;
        
        var Status = UpdateRes;
    }
    return {action: action,Status:Status}
}




