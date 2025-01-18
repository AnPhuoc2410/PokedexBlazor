window.lazyLoad = {
    observe: function (element, dotNetHelper) {
        const observer = new IntersectionObserver((entries, observer) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    dotNetHelper.invokeMethodAsync('LoadMorePokemon');
                    observer.unobserve(entry.target);
                }
            });
        });
        observer.observe(element);
    }
};
