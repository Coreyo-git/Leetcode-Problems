/// <summary>
/// Formats the error message for a test case by including the test name, expected result, and actual result.
/// </summary>
/// <param name="test">The name or description of the test case.</param>
/// <param name="expected">The expected result of the test case.</param>
/// <param name="actual">The actual result obtained during the test case.</param>
/// <returns>A formatted error message that includes the test case details.</returns>
function formatTestErrorMessage(testNumber, expected, actual) {
    let expectedString, actualString;

    try {
        if (expected === null || actual === null)
            throw new Error("Expected or actual value is null.");

        expectedString = formatObject(expected);
        actualString = formatObject(actual);
    } catch (error) {
        return `Error in test ${testNumber}: ${error.message}`;
    }

    return `-----\nTest ${testNumber} Failed\nExpected: ${expectedString}\nActual: ${actualString}\n-----`;
}

function formatObject(obj) {
    if (obj === null) {
        return "object is null";
    }

    if (Array.isArray(obj)) {
        return "[" + obj.map((item) => formatObject(item)).join(", ") + "]";
    } else if (
        typeof obj === "object" &&
        obj.toString === Object.prototype.toString
    ) {
        // Plain objects
        const entries = Object.entries(obj).map(
            ([key, value]) => `${key}: ${formatObject(value)}`
        );
        return `{ ${entries.join(", ")} }`;
    } else if (
        obj instanceof Set ||
        obj instanceof Map ||
        obj instanceof WeakSet ||
        obj instanceof WeakMap
    ) {
        // Convert iterable objects -> array
        return formatObject([...obj]);
    } else {
        return obj.toString();
    }
}

function isArrayEqual(a, b) {
    // check length
    if (a.length != b.length) {
        return false;
    } else {
        let result = false;

        // comparing each element
        for (let i = 0; i < a.length; i++) {
            if (a[i] !== b[i]) {
                return false;
            } else {
                result = true;
            }
        }
        return result;
    }
}

module.exports = { formatTestErrorMessage, isArrayEqual };
