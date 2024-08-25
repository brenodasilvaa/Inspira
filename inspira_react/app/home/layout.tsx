import { AppBar, Box, Button, Container, Grid, Toolbar, Typography } from '@mui/material';

export default function HomeLayout({
  children, // will be a page or nested layout
}: {
  children: React.ReactNode
}) {
    return (
        <>
          <AppBar position="absolute">
            <Toolbar>
              <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
                Inspira Music
              </Typography>
              <Button color="inherit">Login</Button>
            </Toolbar>
          </AppBar>
            <Grid item xs={12} sm={9} md={10}>
            <Box margin={2} display={'flex'} flexDirection={'row'} justifyContent={'space-around'} alignContent={'center'}>
                {children} {/* Space to inject content like cards */}
            </Box>
          </Grid>
          <AppBar position="sticky"  color="default">
            <Toolbar>
          <Typography variant="body2" color="textSecondary" align="center">
            © {new Date().getFullYear()} My Application. All rights reserved.
          </Typography>
         </Toolbar>
         </AppBar>
        </>
      );
}

