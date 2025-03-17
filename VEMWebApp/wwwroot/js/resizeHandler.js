export function registerResizeHandler(dotNetHelper) {
    function resizeListener() {
        dotNetHelper.invokeMethodAsync('OnResize', window.innerWidth);
    }
    window.addEventListener('resize', resizeListener);
    // Call it once to set the initial state
    resizeListener();
}