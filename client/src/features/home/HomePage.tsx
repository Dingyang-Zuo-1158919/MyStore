import { Box, Typography } from "@mui/material";
import Slider from "react-slick";

export default function HomePage() {
    const settings = {
        dots: true,
        infinite: true,
        speed: 500,
        slidesToShow: 1,
        slidesToScroll: 1
    };

    return (
        <>
            <Slider {...settings}>
                <div>
                    <img src='/images/小さな生き物.jpg' alt="spitz1" style={{ display: 'block', width: '100%', maxHeight: 500 }} />
                </div>
                <div>
                    <img src='/images/醒めない.jpg' alt="spitz2" style={{ display: 'block', width: '100%', maxHeight: 500 }} />
                </div>
                <div>
                    <img src='/images/見っけ.jpg' alt="spitz3" style={{ display: 'block', width: '100%', maxHeight: 500 }} />
                </div>
            </Slider>
            <Box display='flex' justifyContent='center' sx={{ p: 4 }}>
                <Typography variant='h1'>
                    Welcome to Spitz Shop!
                </Typography>
            </Box>
        </>
    )
}