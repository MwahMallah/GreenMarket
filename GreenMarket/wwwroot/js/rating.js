
const ratings = document.querySelectorAll(".rating");

if (ratings.length > 0) {
    initRatings(ratings);
}

function initRatings(ratings) {
    for (const rating of ratings) {
        initRating(rating);
    }

    function initRating(rating) {
        let ratingActive, ratingValue;
        initRatingArgs(rating);
        setActiveRatingWidth(ratingValue.innerHTML);
    
        if (rating.classList.contains("rating__set")) {
            enableRatingSet(rating);
        }
        
        function setActiveRatingWidth(value) {
            let activeRatingWidth;
            //if value is number
            if (!isNaN(value)) {
                activeRatingWidth = (value / 5) * 100;
            } else {
                activeRatingWidth = 0;
            }
        
            ratingActive.style.width = `${activeRatingWidth}%`;
        }
        
        function initRatingArgs(rating) {
            ratingActive = rating.querySelector(".rating__active");
            ratingValue  = rating.querySelector(".rating__value");
        }
        
        function enableRatingSet(rating) {
            const ratingItems = rating.querySelectorAll(".rating__item");
            for (const ratingItem of ratingItems) {
                ratingItem.addEventListener("mouseenter", () => {
                    setActiveRatingWidth(ratingItem.value);
                });
        
                ratingItem.addEventListener("mouseleave", () => {
                    setActiveRatingWidth(ratingValue.innerHTML);
                });
            
                ratingItem.addEventListener("click", () => {
                    //format in 1.0 format
                    ratingValue.innerHTML = (parseFloat(ratingItem.value)).toFixed(1);
                    setActiveRatingWidth(ratingValue.innerHTML);
                
                    fetch('/UserProfile/RateProduct', {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json',
                            'RequestVerificationToken': '@Html.AntiForgeryToken()'
                        },
                        body: JSON.stringify({
                        orderId: ratingItem.getAttribute("order_id"),
                        rating: ratingItem.value })
                    })
                    .then(res => res.text())
                    .then(msg => Toastify({
                        text: msg,
                        duration: 3000,
                        close: true,
                        gravity: "top",
                        position: "center",
                        backgroundColor: "green",
                        stopOnFocus: true
                    }).showToast());
                });
            }
        }
    }
}