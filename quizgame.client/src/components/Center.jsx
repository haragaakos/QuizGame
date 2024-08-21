
import PropTypes from 'prop-types';
import { Grid } from '@mui/material';

function Center(props) {
    return (
        <Grid
            container
            direction="column"
            alignItems="center"
            justifyContent="center"
            sx={{ minHeight: '100vh' }}
        >
            <Grid item xs={1}>
                {props.children}
            </Grid>
        </Grid>
    );
}

Center.propTypes = {
    children: PropTypes.node,
};

export default Center;