$(document).ready(function() {
  $('.contacts').click(function(){
    $('html').animate({
        scrollTop: $('.footer').offset().top
      },  {
        duration: 370,   // по умолчанию «400»
        easing: "linear" // по умолчанию «swing»500);
  });
});
  $('.tovar').click(function(){
    var nomer= $(this).attr('id');
    $('.modal')
      .css("display", "block")
      .animate({ opacity: 1 }, 300);
    $('.modal img').attr('src', '../img/' + nomer + '.jpg')
    });
  $('.exit').click(function(){
    $('.modal').animate({ opacity: 0 }, 198, function () {
            $(this).css("display", "none");
    });
  });
  $('#itog').click(function(){
    var nomer= $(this).attr('id');
    $('.modal_cart')
      .css("display", "block")
      .animate({ opacity: 1 }, 300);
  });
  $('.exit').click(function(){
    $('.modal_cart').animate({ opacity: 0 }, 198, function () {
            $(this).css("display", "none");
    });
  });
});
  //$("#myModal")
  //.css("display", "block")
  //.animate({ opacity: 1 }, 198);
  //});
