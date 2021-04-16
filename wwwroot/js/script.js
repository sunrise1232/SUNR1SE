$(document).ready(function(){
    
    // Modal

    $('[data-modal=authorization]').on('click', function() {
        $('.modal, #authorization').fadeIn('slow');
    });
    $('.modal__close').on('click', function() {
        $('.overlay, #tour, #authorization').fadeOut('slow');
    });

    $('.catalog-item').each(function(i) {
        $(this).on('click', function() {
            //$('#order .modal__descr').text($('.catalog-item__subtitle').eq(i).text());
            $('.modal, #tour').fadeIn('slow')
        });
    });




    //


});