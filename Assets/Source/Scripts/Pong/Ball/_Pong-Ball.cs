// * NAMESPACE HEADER FILE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Pong;

namespace Pong.Ball {
    /*
     * Player lastTouchedBy
     * Destroys the ball and increments points
    */
    /// <summary>
    /// Represents the physical ball that is visible on game screen, and handles
    /// ball logic such as scoring and serving
    /// </summary>
    public partial class PongBall {}

    /*
     * Handle collisions -> adjust trajectory
       speedX = GameCache.BALL_SPEED_VP
       velocityY = ForceAdjustment => Equation (due to possible derivatives) 
    */
    /// <summary>
    /// Controls the physical ball that is visible on game screen, calculating
    /// trajectory, movement, and collisions
    /// </summary>
    public partial class PongBallController : MonoBehaviour {}

    /*public static class BallStatus {
        private const int GOAL = 1;

        public const int GOAL_LEFT = -GOAL;
        public const int NO_GOAL = 0;
        public const int GOAL_RIGHT = GOAL;
        public const int REBOUNDED = 2;

        public static int INVERT(int ballStatus) {
            return ballStatus * -1;
        }

        public static bool IsGoal(int ballStatus) {
            return Mathf.Abs(ballStatus) == GOAL;
        }
    }*/

    /// <summary>
    /// Defines constants for keeping track of which player scored last which is used
    /// to determine which player's turn it is to serve
    /// </summary>
    public static class BallGoal {
        public const bool LEFT = true;
        public const bool RIGHT = false;

        // Note: we don't even need an INVERT() function because the ! operator already does that with bools! 
    }
}