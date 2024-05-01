import { AppBar, CssBaseline, Toolbar, Typography } from "@mui/material";

export default function Header() {
    return (
        <AppBar position='static' sx={{ mb: 4 }}>
            <Toolbar>
                <Typography variant='h4'>
                    Spitz Store
                </Typography>
            </Toolbar>
        </AppBar>
    )
}