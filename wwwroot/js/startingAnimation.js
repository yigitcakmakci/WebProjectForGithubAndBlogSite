document.addEventListener("DOMContentLoaded", function () {
    const animatedDivs = document.querySelectorAll('.animated-div');

    function checkVisibility() {
        const triggerPoint = window.innerHeight * 0.75; // Görüntüleme alanının %75'ine geldiğinde
        animatedDivs.forEach((div, index) => {
            const rect = div.getBoundingClientRect();
            if (rect.top < triggerPoint) {
                // İlk blok için 0ms, diğerleri için 300ms gecikme
                const delay = index === 0 ? 0 : 300; // Sadece ilk blok için gecikme sıfır
                setTimeout(() => {
                    div.style.opacity = '1';
                    div.style.transform = 'translateY(0)';
                }, delay);
            }
        });
    }

    // Sayfa ilk yüklendiğinde kontrol et
    checkVisibility();

    // Sayfa kaydırıldıkça kontrol et
    window.addEventListener('scroll', checkVisibility);
});
