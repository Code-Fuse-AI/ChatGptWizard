/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./**/*.{razor,html,cshtml}"],
    theme: {
        screens: {
            'xs': '320px', // added extra small breakpoint for smaller mobile devices
            'sm': '640px',
            'md': '768px', // modified breakpoint for medium screens (tablets)
            'lg': '1024px',
            'xl': '1280px',
            '2xl': '1536px',
        },
        extend: {
            margin: {
                'sm': '0 0 10px 0', //added
            },
            colors: {
                'Primary': '#6187A0', // calm pastel blue
                'PrimaryLighten': '#8FB5CA', // lighter shade of pastel blue
                'Secondary': '#A9A9A9', // added secondary gray color
                'GrayLight': '#F5F5F5',
                'Surface': '#FFFFFF', // Card bg color
            },
        },
    },
    variants: {},
    plugins: [],
}
