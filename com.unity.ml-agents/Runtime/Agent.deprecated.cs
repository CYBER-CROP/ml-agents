using System;
using UnityEngine;

namespace Unity.MLAgents
{
    public partial class Agent
    {
        [Obsolete("CollectDiscreteActionMasks has been deprecated. Please use WriteDiscreteActionMask instead.", false)]
        public virtual void CollectDiscreteActionMasks(DiscreteActionMasker actionMasker)
        {
        }

        [Obsolete("The Heuristic(float[]) method has been deprecated.  Please use Heuristic(float[], int[]) instead.")]
        public virtual void Heuristic(float[] continuousActionsOut)
        {
            Debug.LogWarning("Heuristic method called but not implemented. Returning placeholder actions.");
            Array.Clear(continuousActionsOut, 0, continuousActionsOut.Length);
        }

        [Obsolete("The OnActionReceived(float[]) method has been deprecated" +
            " Please use OnActionReceived(ActionSegment<float>, ActionSegment<int>).", false)]
        public virtual void OnActionReceived(float[] vectorAction) {}

        /// <summary>
        /// Returns the last action that was decided on by the Agent.
        /// </summary>
        /// <returns>
        /// The last action that was decided by the Agent (or null if no decision has been made).
        /// </returns>
        /// <seealso cref="OnActionReceived(float[])"/>
        [Obsolete("GetAction has been deprecated, please use GetStoreContinuousActions, Or GetStoreDiscreteActions.")]
        public float[] GetAction()
        {
            return m_Info.storedVectorActions;
        }

    }
}
