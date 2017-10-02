using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBase
{
    namespace Flyweights
    {
        public enum ErrorMessage
        {
            /** bad parameters. */
            BAD_PARAMETERS,
            /** illegal access. */
            ILLEGAL_ACCESS,
            /** illegal object type. */
            ILLEGAL_OBJECT_TYPE,
            /** illegal operation. */
            ILLEGAL_OPERATION,
            /** invalid argument. */
            INTERNAL_BAD_ARGUMENT,
            /** internal error. */
            INTERNAL_ERROR,
            /** invalid data format. */
            INVALID_DATA_FORMAT,
            /** invalid data type. */
            INVALID_DATA_TYPE,
            /** invalid field. */
            INVALID_FIELD,
            /** invalid operand. */
            INVALID_OPERAND,
            /** invalid operation. */
            INVALID_OPERATION,
            /** invalid parameter. */
            INVALID_PARAM,
            /** invalid path parameters. */
            INVALID_PATH_PARAM,
            /** invalid resource type. */
            INVALID_RESOURCE_TYPE,
            /** missing id. */
            MISSING_ID,
            /** missing operand. */
            MISSING_OPERAND,
            /** multiple records found. */
            MULTIPLE_RECORD_FOUND,
            /** no record found. */
            NO_RECORD_FOUND,
            /** can create revision of deleted record. */
            POST_DELETED_REC,
            /** no data for POST operation. */
            POST_INDATA
        }
    }
}
